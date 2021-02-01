using System.Collections.Generic;
using System.Threading.Tasks;
using Oqtane.Survey.Models;
using Oqtane.Survey.Server.Repository;

namespace Oqtane.Survey.Repository
{
    public interface ISurveyRepository
    {
        Task<List<OqtaneSurvey>> GetAllSurveysAsync();
        List<OqtaneSurvey> GetAllSurveysByModule(int ModuleId);
        Task<OqtaneSurvey> GetSurvey(int Id);
        Task<OqtaneSurvey> CreateSurveyAsync(OqtaneSurvey NewSurvey);
        Task<OqtaneSurvey> UpdateSurveyAsync(OqtaneSurvey objExistingSurvey);
        Task<bool> DeleteSurveyAsync(OqtaneSurvey objExistingSurvey);
        Task<List<OqtaneSurveyItem>> GetAllSurveyItemsAsync(int SurveyId);
        Task<OqtaneSurveyItem> GetSurveyItemAsync(int SurveyItemId);
        Task<OqtaneSurveyItem> CreateSurveyItemAsync(OqtaneSurveyItem NewSurveyItem);
        Task<OqtaneSurveyItem> UpdateSurveyItemAsync(OqtaneSurveyItem objExistingSurveyItem);
        Task<bool> DeleteSurveyItemAsync(SurveyItem objExistingSurveyItem);
        Task<bool> CreateSurveyAnswersAsync(DTOSurvey paramDTOSurvey);
    }
}
