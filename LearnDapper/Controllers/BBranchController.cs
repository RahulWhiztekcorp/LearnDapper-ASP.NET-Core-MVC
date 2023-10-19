using LearnDapper.Models;
using LearnDapper.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnDapper.Controllers
{
    public class BBranchController : Controller
    {
        public readonly IBranchRepository _branchRepository;
        public BBranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }
        // GET: BBranchController
        public async Task<IActionResult> Index()
        {
            return View(await _branchRepository.GetAllAsync());
        }
        // GET: BBranchController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _branchRepository.GetByIdAsync(id));
        }

        // GET: BBranchController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BBranchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Branch branch)
        {
            try
            {
                await _branchRepository.Create(branch);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BBranchController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _branchRepository.GetByIdAsync(id));
        }

        // POST: BBranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Branch branch)
        {
            try
            {
                await _branchRepository.Update(branch);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BBranchController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _branchRepository.GetByIdAsync(id));
        }

        // POST: BBranchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id,Branch branch)
        {
            try
            {
                await _branchRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
