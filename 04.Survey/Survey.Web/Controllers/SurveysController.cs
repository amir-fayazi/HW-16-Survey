using Microsoft.AspNetCore.Mvc;
using Survey.Application.Exceptions;
using Survey.Application.Services;
using Survey.Domain.Contracts.Repositories;
using Survey.Infrastructure.Persistence;
using Survey.Infrastructure.Repositories;

namespace Survey.Web.Controllers
{
    public class SurveysController : Controller
    {

        public IActionResult Index()
        {

            using AppDbContext context = new AppDbContext();
            var surveyRepository = new SurveyRepository(context);
            var unitOfWork = new UnitOfWork(context);
            var surveyParticipationRepository = new SurveyParticipationRepository(context);
            var surveyService = new SurveyService(surveyRepository, unitOfWork, surveyParticipationRepository);


            var surveys = surveyService.GetActiveSurveys();
            return View(surveys);

        }

        public IActionResult Participate(int id)
        {
            using AppDbContext context = new AppDbContext();
            var surveyRepository = new SurveyRepository(context);
            var unitOfWork = new UnitOfWork(context);
            var surveyParticipationRepository = new SurveyParticipationRepository(context);
            var surveyService = new SurveyService(surveyRepository, unitOfWork, surveyParticipationRepository);


            try
            {
                var surveyVoting = surveyService.GetSurveyForVoting(id);
                return View(surveyVoting);
            }
            catch (NotFoundException)
            {

                return NotFound("Survey not found!!!");
            }


        }

 

    }
}
