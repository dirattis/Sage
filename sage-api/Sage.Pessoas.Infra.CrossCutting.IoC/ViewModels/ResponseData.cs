

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels
{
    public class ResponseData<T>
    {
        public bool Success
        {
            get
            {
                return !Errors.Any();
            }
        }

        public T Data { get; set; }

        public List<string> Errors { get; set; } = new List<string>();
    }

    public class ResponseData
    {
        public ResponseData() 
        {
        }

        public ResponseData(ModelStateDictionary modelState) 
        {
            ModelState = modelState;
        }

        public ModelStateDictionary ModelState { get; set; }
        
        public bool Success
        {
            get { 
                return !Errors.Any(); 
            }
        }

        public List<string> Errors { get; set; } = new List<string>();
    }
}
