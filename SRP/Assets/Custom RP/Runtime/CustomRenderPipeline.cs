using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Custom_RP.Runtime
{
    // Each frame Unity invokes Render on the RP instance.
    
    public class CustomRenderPipeline : RenderPipeline
    {
        private readonly CameraRenderer _renderer = new CameraRenderer();
        
        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            foreach (var camera in cameras)
            {
                _renderer.Render(context, camera);
            }
        }
    }
}
