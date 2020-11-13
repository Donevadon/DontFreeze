using System;
using System.Collections;
using System.Collections.Generic;

namespace Game
{
    public abstract class StateHealth
    {
        protected IHealth health;//TODO: Реализация жизни игрока
        protected IThirst thirst;//TODO: Реализация жажды игрока
        protected Stamina stamina;//TODO: Реализация стамины игрока
        protected IHunger hunger;//TODO: Реализация голода игрока
        protected IStateUI UI;//TODO: Реазация сингл менеджера UI состояний

        public StateHealth()
        {
            Initialize();
        }

        public bool RecoveryHealth(float HP)
        {
            return health.Recovery(HP);
        }

        public void RemoveHealth(float damage)
        {
            health.Remove(damage);
        }

        public bool SpeedUp()
        {
            bool result = stamina.SpeedUp();
            return result;
        }
        protected abstract void Initialize();
    }
}