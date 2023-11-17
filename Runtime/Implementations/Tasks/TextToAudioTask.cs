using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace HuggingFace.API
{
    public class TextToAudioTask : TaskBase<string, byte[]>
    {
        public override string taskName => "TextToAudio";
        public override string defaultEndpoint => "https://api-inference.huggingface.co/models/facebook/musicgen-small";

        protected override IPayload GetPayload(string input, object context)
        {
            return new JObjectPayload(new JObject
            {
                ["inputs"] = input
            });
        }

        protected override string[] LoadBackupEndpoints()
        {
            return new string[] { };
        }

        protected override bool PostProcess(object raw, string input, object context, out byte[] response, out string error)
        {
            return base.PostProcess(raw, input, context, out response, out error);
        }
    }
}