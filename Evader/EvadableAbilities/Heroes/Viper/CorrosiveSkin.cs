﻿namespace Evader.EvadableAbilities.Heroes.Viper
{
    using Base;
    using Base.Interfaces;

    using Ensage;

    using Modifiers;

    using static Data.AbilityNames;

    internal class CorrosiveSkin : EvadableAbility, IModifier
    {
        #region Constructors and Destructors

        public CorrosiveSkin(Ability ability)
            : base(ability)
        {
            Modifier = new EvadableModifier(HeroTeam, EvadableModifier.GetHeroType.LowestHealth);

            DisableTimeSinceCastCheck = true;

            Modifier.AllyCounterAbilities.Add(Lotus);
            Modifier.AllyCounterAbilities.Add(AphoticShield);
            Modifier.AllyCounterAbilities.Add(FortunesEnd);
        }

        #endregion

        #region Public Properties

        public EvadableModifier Modifier { get; }

        #endregion

        #region Public Methods and Operators

        public override void Check()
        {
        }

        public override void Draw()
        {
        }

        public override float GetRemainingTime(Hero hero = null)
        {
            return 0;
        }

        #endregion
    }
}