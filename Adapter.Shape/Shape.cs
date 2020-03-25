using System;

namespace Adapter.Shape
{
    public interface Shape
    {
        void Draw();
        void Resize();
        String Description();
        bool IsHide();
    }
}