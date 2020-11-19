using UnityEngine;

namespace Game.UnityEngine.UnityControl
{
    [CreateAssetMenu(fileName = "MovementSetting", menuName = "Settings/MovementSetting", order = 0)]
    public class MovementSetting : ScriptableObject 
    {
        public float SpeedRun;
        public float SpeedWalk;
    }
}