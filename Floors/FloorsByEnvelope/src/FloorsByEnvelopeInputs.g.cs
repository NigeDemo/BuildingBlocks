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

namespace FloorsByEnvelope
{
    public class FloorsByEnvelopeInputs: S3Args
    {
		/// <summary>
		/// Height of ground floor.
		/// </summary>
		[JsonProperty("Ground Floor Height")]
		public double GroundFloorHeight {get;}

		/// <summary>
		/// Standard height of repeated floors.
		/// </summary>
		[JsonProperty("Standard Floor Height")]
		public double StandardFloorHeight {get;}

		/// <summary>
		/// Multiplier of standard floor height for mechanical floors.
		/// </summary>
		[JsonProperty("Mechanical Floor Height Ratio")]
		public double MechanicalFloorHeightRatio {get;}

		/// <summary>
		/// Setback of slab edges from envelope.
		/// </summary>
		[JsonProperty("Floor setback")]
		public double FloorSetback {get;}


        
        /// <summary>
        /// Construct a FloorsByEnvelopeInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FloorsByEnvelopeInputs() : base()
        {
			this.GroundFloorHeight = 7;
			this.StandardFloorHeight = 5;
			this.MechanicalFloorHeightRatio = 2.5;
			this.FloorSetback = 1.5;

        }


        /// <summary>
        /// Construct a FloorsByEnvelopeInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FloorsByEnvelopeInputs(double groundfloorheight, double standardfloorheight, double mechanicalfloorheightratio, double floorsetback, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.GroundFloorHeight = groundfloorheight;
			this.StandardFloorHeight = standardfloorheight;
			this.MechanicalFloorHeightRatio = mechanicalfloorheightratio;
			this.FloorSetback = floorsetback;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}