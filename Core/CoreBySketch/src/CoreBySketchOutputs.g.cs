// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace CoreBySketch
{
    public class CoreBySketchOutputs: ResultsBase
    {
		/// <summary>
		/// Height of the service core.
		/// </summary>
		[JsonProperty("Height")]
		public double Height {get;}


        
        /// <summary>
        /// Construct a CoreBySketchOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public CoreBySketchOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a CoreBySketchOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public CoreBySketchOutputs(double height): base()
        {
			this.Height = height;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}