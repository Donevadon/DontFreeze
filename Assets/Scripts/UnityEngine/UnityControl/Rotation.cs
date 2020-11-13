using UnityEngine;

namespace Game.UnityEngine.UnityControl
{
    public class Rotation : MonoBehaviour, IRotate
    {
        private SpriteRenderer spriteRenderer;
        private Sprite upSprite;
        private bool isUp;
        private Sprite bottomSprite;
        private bool isBottom;
        private Sprite rightSprite;
        private bool isRight;
        private Sprite leftSprite;
        private bool isLeft;

        private void Awake() 
        {
            LoadSprite(); 
        }

        private void LoadSprite()
        {
            upSprite = Resources.Load<Sprite>("Sprites/Player/Up");
            bottomSprite = Resources.Load<Sprite>("Sprites/Player/Bottom");
            leftSprite = Resources.Load<Sprite>("Sprites/Player/Left");
            rightSprite = Resources.Load<Sprite>("Sprites/Player/Right");
        }

        public void ChangeRotate(float accelerationUp, float accelerationRight)
        {
            
        }

    }
}