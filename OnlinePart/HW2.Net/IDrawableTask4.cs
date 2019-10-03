namespace HW2.Net
{
    public interface IDrawableTask4
    {
        void Draw();

        void DrawAll(params IDrawableTask4[] array);
    }
}