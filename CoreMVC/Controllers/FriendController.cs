using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Controllers
{
    public class FriendController : Controller
    {
        private IFriendRepository _context;

        public FriendController(IFriendRepository context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var friendList = await _context.GetAllFriends();
            return View(friendList);
        }

        //GET: Friend/Create
        public IActionResult Create()
        {
            return View();
        }
        //POST: Friend/Create
        [HttpPost]
        public async Task<IActionResult> Create(Friend friend)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Add(friend);
            var friendList = await _context.GetAllFriends();
            return View("Index", friendList);
        }
        //GET: Friend/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var friend = await _context.GetFriend(id);
            return View(friend);

        }
        //POST: Friend/Delete
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteFriend(int id)
        {
            await _context.Delete(id);
            var friendList = await _context.GetAllFriends();
            return View("Index", friendList);
        }

        //GET: Friend/Update
        public async Task<IActionResult> Edit(int id)
        {
            var updateFriend = await _context.GetFriend(id);
            return View(updateFriend);
        }

        //POST: Friend/Update
        [HttpPost]
        public async Task<IActionResult> Edit(Friend friend)
        {
            _context.Update(friend);
            var friendList = await _context.GetAllFriends();
            return View("Index", friendList);
        }
    }
}
