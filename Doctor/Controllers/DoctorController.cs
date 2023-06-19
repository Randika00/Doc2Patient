using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Doctor.Data;
using Doctor.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Doctor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService ?? throw new ArgumentNullException(nameof(doctorService));
        }


        /// <summary>
        /// Get all doctor
        /// </summary>
        /// <returns>return the list of doctor</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_doctorService.GetDoctors());
        }

        /// <summary>
        /// Get doctor by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the doctor with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _doctorService.GetDoctor(id) != null ? Ok(_doctorService.GetDoctor(id)) : NoContent();
        }

        /// <summary>
        /// Add doctors
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns>Return the added Doctor</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Doctor doctor)
        {
            return Ok(_doctorService.AddDoctor(doctor));
        }

        /// <summary>
        /// Update the doctor
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns>Return the updated doctor</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Doctor doctor)
        {
            return Ok(_doctorService.UpdateDoctor(doctor));
        }

        /// <summary>
        /// Delete the doctor with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _doctorService.DeleteDoctor(id);

            return result.HasValue & result == true ? Ok($"doctor with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the doctor with ID:{id}.");
        }
    }
}