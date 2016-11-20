﻿namespace Evader.EvadableAbilities.Heroes.CentaurWarrunner
{
    using Base;
    using Base.Interfaces;

    using Ensage;

    using Modifiers;

    using static Data.AbilityNames;

    internal class HoofStomp : AOE, IModifier
    {
        #region Constructors and Destructors

        public HoofStomp(Ability ability)
            : base(ability)
        {
            Modifier = new EvadableModifier(HeroTeam, EvadableModifier.GetHeroType.LowestHealth);

            CounterAbilities.Add(PhaseShift);
            CounterAbilities.Add(BallLightning);
            CounterAbilities.Add(SleightOfFist);
            CounterAbilities.Add(Eul);
            CounterAbilities.Add(Manta);
            CounterAbilities.AddRange(VsDisable);
            CounterAbilities.AddRange(VsDamage);
            CounterAbilities.AddRange(VsPhys);
            CounterAbilities.AddRange(Invis);
            CounterAbilities.Add(SnowBall);
            CounterAbilities.Add(Armlet);
            CounterAbilities.Add(Bloodstone);

            Modifier.AllyCounterAbilities.AddRange(AllyShields);
            Modifier.AllyCounterAbilities.AddRange(Invul);
            Modifier.AllyCounterAbilities.AddRange(VsPhys);
        }

        #endregion

        #region Public Properties

        public EvadableModifier Modifier { get; }

        #endregion
    }
}