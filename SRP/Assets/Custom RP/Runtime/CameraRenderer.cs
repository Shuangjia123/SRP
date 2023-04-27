using UnityEngine;
using UnityEngine.Rendering;

namespace Custom_RP.Runtime
{
    // 现阶段来说 Our camera renderer is roughly equivalent to the scriptable renderers of the Universal RP.
    public class CameraRenderer
    {
        private ScriptableRenderContext _context;
        private Camera _camera;

        public void Render (ScriptableRenderContext context, Camera camera) {
            this._context = context;
            this._camera = camera;

            Setup();
            DrawVisibleGeometry();
            Submit();
        }
        
        // VP矩阵
        // 但是为什么即使没有这一步，修改相机的位置也会产生影响（旋转不会产生影响）
        void Setup ()
        {
            _context.SetupCameraProperties(_camera);
        }
        
        private void DrawVisibleGeometry ()
        {
            _context.DrawSkybox(_camera);
        }
        
        private void Submit ()
        {
            _context.Submit();
        }
    }
}