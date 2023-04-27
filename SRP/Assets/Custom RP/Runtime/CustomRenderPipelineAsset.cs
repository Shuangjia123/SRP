using UnityEngine;
using UnityEngine.Rendering;

namespace Custom_RP.Runtime
{
    // RP asset 是一个句柄和存储数据的地方
    [CreateAssetMenu(menuName = "Rendering/Custom Render Pipeline")]
    public class CustomRenderPipelineAsset :  RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return new CustomRenderPipeline();
        }
    }
}
