using Microsoft.AspNetCore.Mvc;
using Survey.Application.Exceptions;
using Survey.Application.Services;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos.Vote;
using Survey.Domain.Entities;
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


            var surveysDto = surveyService.GetActiveSurveys();
            return View(surveysDto);

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

        public IActionResult SubmitVote(SubmitVoteDto submitVote)
        {

            return Json(new
            {
                submitVote.SurveyId,
                submitVote.Answers
            });

        }

        //public List<Vote> CreateVotes()
        //{

        //}



    }
}
