

using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels
{
    public class ResponseData<T>
    {
        public ResponseData() { }

        public ResponseData(T data)
        {
            Data = data;
        }

        public bool Success
        {
            get
            {
                return Errors == null || !Errors.Any();
            }
        }

        public T Data { get; set; }

        public List<string> Errors { get; private set; }
    }

    public class ResponseData
    {
        public ResponseData(string errorMessage)
        {
            Errors = new List<string>() { errorMessage };
        }

        public ResponseData(List<string> errors) 
        {
            Errors = errors;
        }

        public ResponseData(ModelStateDictionary modelState) 
        {
            ModelState = modelState;
        }

        [JsonIgnore]
        public ModelStateDictionary ModelState { get; set; }
        
        public bool Success
        {
            get {
                return Errors == null || !Errors.Any();
            }
        }

        public List<string> Errors { get; private set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
