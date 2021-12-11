using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Empleado
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }


        //private readonly IEmpleadoService empleadoService;

        //public GridModel(IEmpleadoService empleadoService)
        //{
        //    this.empleadoService = empleadoService;
        //}


        public IEnumerable<EmpleadoEntity> GridList { get; set; } = new List<EmpleadoEntity>();


        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await service.EmpleadoGet();                   

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
        //public string Mensaje { get; set; } = "";
        //public async Task<IActionResult> OnGet()
        //{

        //    try
        //    {
        //        GridList = await empleadoService.Get();

        //        if (TempData.ContainsKey("Msg"))
        //        {
        //            Mensaje = TempData["Msg"] as string;
        //        }

        //        TempData.Clear();

        //        return Page();

        //    }
        //    catch (Exception ex)
        //    {

        //       return Content(ex.Message) ;
        //    }

        //}

        //public async Task<IActionResult> OnGetEliminar(int id)
        //{

        //    try
        //    {
        //        var result = await empleadoService.Delete( new() { IdEmpleado= id});

        //        if (result.CodeError!=0)
        //        {
        //            throw new Exception(result.MsgError);
        //        }

        //        TempData["Msg"] = "Se elimino correctamente";

        //        return Redirect("Grid");


        //    }
        //    catch (Exception ex)
        //    {

        //        return Content(ex.Message);
        //    }

        //}
    }
}
