using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MinhaLojaVirtual.Infra.IRepository;
using MinhaLojaVirtual.Models;
using System.Text;

namespace MinhaLojaVirtual.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;

        public UserController(IUserRepository userRepository, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _userRepository = userRepository;
            _signInManager = signInManager;
            _userManager = userManager; 
        }

        // GET: UserController
        public ActionResult Index()
        {


            return View();
        }

        // POST: UserController
        [HttpPost]
        public async Task<IActionResult> Index(UserModel model, string returnUrl = null)
        {
            try
            {
                returnUrl ??= Url.Content("~/");

                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.email, model.password, true, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return LocalRedirect(returnUrl);
                    }
                    ModelState.AddModelError(string.Empty, "Tentativa de login inválida.");
                    return View(model);
                }
                return View(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public async Task<IActionResult> Create(UserModel model)
        {
            try
            {
                var encryptPassword = encrypt(model.password);
                var form = new UserModel(model.name, model.email, encryptPassword);

                await _userRepository.Save(form);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["ErroStatus"] = "Erro!";
                return View();
            }
        }

        protected string encrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";

            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
