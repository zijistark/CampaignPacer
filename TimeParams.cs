﻿
using System.Runtime.CompilerServices;

namespace CampaignPacer
{
	public struct TimeParams
	{
		/* units */
		public const long MsecPerSecL = 1000L;
		public const long SecPerMinL = 60L;
		public const long MinPerHourL = 60L;
		public const long HourPerDayL = 24L;
		public readonly long DayPerWeekL; // configurable
		public readonly long WeekPerSeasonL; // configurable
		public const long SeasonPerYearL = 4L;

		/* dependent special units */
		public readonly long DayPerSeasonL;
		public readonly long DayPerYearL;

		/* ticks per unit */
		public readonly long TickPerMsecL; // configurable
		public readonly long TickPerSecL;
		public readonly long TickPerMinL;
		public readonly long TickPerHourL;
		public readonly long TickPerDayL;
		public readonly long TickPerWeekL;
		public readonly long TickPerSeasonL;
		public readonly long TickPerYearL;

		/* double-precision floating-point ticks per unit */
		public readonly double TickPerMsec;
		public readonly double TickPerSec;
		public readonly double TickPerMin;
		public readonly double TickPerHour;
		public readonly double TickPerDay;
		public readonly double TickPerWeek;
		public readonly double TickPerSeason;
		public readonly double TickPerYear;

		/* single-precision floating-point ticks per unit */
		public readonly float TickPerMsecF;
		public readonly float TickPerSecF;
		public readonly float TickPerMinF;
		public readonly float TickPerHourF;
		public readonly float TickPerDayF;
		public readonly float TickPerWeekF;
		public readonly float TickPerSeasonF;
		public readonly float TickPerYearF;

		/* units (vanilla) */
		public const long OldMsecPerSecL = 1000L;
		public const long OldSecPerMinL = 60L;
		public const long OldMinPerHourL = 60L;
		public const long OldHourPerDayL = 24L;
		public const long OldDayPerWeekL = 7L;
		public const long OldWeekPerSeasonL = 3L;
		public const long OldSeasonPerYearL = 4L;

		/* ticks per unit (vanilla) */
		public const long OldTickPerMsecL = 10L;
		public const long OldTickPerSecL = OldMsecPerSecL * OldTickPerMsecL;
		public const long OldTickPerMinL = OldSecPerMinL * OldTickPerSecL;
		public const long OldTickPerHourL = OldMinPerHourL * OldTickPerMinL;
		public const long OldTickPerDayL = OldHourPerDayL * OldTickPerHourL;
		public const long OldTickPerWeekL = OldDayPerWeekL * OldTickPerDayL;
		public const long OldTickPerSeasonL = OldWeekPerSeasonL * OldTickPerWeekL;
		public const long OldTickPerYearL = SeasonPerYearL * OldTickPerSeasonL;

		/* double-precision floating-point ticks per unit (vanilla) */
		public const double OldTickPerMsec = (double)OldTickPerMsecL;
		public const double OldTickPerSec = (double)OldTickPerSecL;
		public const double OldTickPerMin = (double)OldTickPerMinL;
		public const double OldTickPerHour = (double)OldTickPerHourL;
		public const double OldTickPerDay = (double)OldTickPerDayL;
		public const double OldTickPerWeek = (double)OldTickPerWeekL;
		public const double OldTickPerSeason = (double)OldTickPerSeasonL;
		public const double OldTickPerYear = (double)OldTickPerYearL;

		/* single-precision floating-point ticks per unit (vanilla) */
		public const float OldTickPerMsecF = (float)OldTickPerMsecL;
		public const float OldTickPerSecF = (float)OldTickPerSecL;
		public const float OldTickPerMinF = (float)OldTickPerMinL;
		public const float OldTickPerHourF = (float)OldTickPerHourL;
		public const float OldTickPerDayF = (float)OldTickPerDayL;
		public const float OldTickPerWeekF = (float)OldTickPerWeekL;
		public const float OldTickPerSeasonF = (float)OldTickPerSeasonL;
		public const float OldTickPerYearF = (float)OldTickPerYearL;

		/* ratios of old/vanilla to our ticks per unit (double-precision) */
		public readonly double TickRatioMsec;
		public readonly double TickRatioSec;
		public readonly double TickRatioMin;
		public readonly double TickRatioHour;
		public readonly double TickRatioDay;
		public readonly double TickRatioWeek;
		public readonly double TickRatioSeason;
		public readonly double TickRatioYear;

		/* ratios of old/vanilla to our ticks per unit (single-precision) */
		public readonly float TickRatioMsecF;
		public readonly float TickRatioSecF;
		public readonly float TickRatioMinF;
		public readonly float TickRatioHourF;
		public readonly float TickRatioDayF;
		public readonly float TickRatioWeekF;
		public readonly float TickRatioSeasonF;
		public readonly float TickRatioYearF;

		public TimeParams(Settings cfg)
		{
			/* independent variables from our config */
			DayPerWeekL = cfg.DaysPerWeek;
			WeekPerSeasonL = cfg.WeeksPerSeason;
			TickPerMsecL = cfg.TicksPerMillisecond;

			/* special units */
			DayPerSeasonL = DayPerWeekL * WeekPerSeasonL;
			DayPerYearL = DayPerSeasonL * SeasonPerYearL;

			/* ticks per unit */
			TickPerSecL = TickPerMsecL * MsecPerSecL;
			TickPerMinL = TickPerSecL * SecPerMinL;
			TickPerHourL = TickPerMinL * MinPerHourL;
			TickPerDayL = TickPerHourL * HourPerDayL;
			TickPerWeekL = TickPerDayL * DayPerWeekL;
			TickPerSeasonL = TickPerWeekL * WeekPerSeasonL;
			TickPerYearL = TickPerSeasonL * SeasonPerYearL;

			/* ticks per unit, double-precision floating point */
			TickPerMsec = (double)TickPerMsecL;
			TickPerSec = (double)TickPerSecL;
			TickPerMin = (double)TickPerMinL;
			TickPerHour = (double)TickPerHourL;
			TickPerDay = (double)TickPerDayL;
			TickPerWeek = (double)TickPerWeekL;
			TickPerSeason = (double)TickPerSeasonL;
			TickPerYear = (double)TickPerYearL;

			/* ticks per unit, single-precision floating point */
			TickPerMsecF = (float)TickPerMsecL;
			TickPerSecF = (float)TickPerSecL;
			TickPerMinF = (float)TickPerMinL;
			TickPerHourF = (float)TickPerHourL;
			TickPerDayF = (float)TickPerDayL;
			TickPerWeekF = (float)TickPerWeekL;
			TickPerSeasonF = (float)TickPerSeasonL;
			TickPerYearF = (float)TickPerYearL;

			/* ratios of vanilla units to new units, double-precision floating-point */
			TickRatioMsec = OldTickPerMsec / TickPerMsec;
			TickRatioSec = OldTickPerSec / TickPerSec;
			TickRatioMin = OldTickPerMin / TickPerMin;
			TickRatioHour = OldTickPerHour / TickPerHour;
			TickRatioDay = OldTickPerDay / TickPerDay;
			TickRatioWeek = OldTickPerWeek / TickPerWeek;
			TickRatioSeason = OldTickPerSeason / TickPerSeason;
			TickRatioYear = OldTickPerYear / TickPerYear;

			/* ratios of vanilla units to new units, single-precision floating-point */
			TickRatioMsecF = (float)TickRatioMsec;
			TickRatioSecF = (float)TickRatioSec;
			TickRatioMinF = (float)TickRatioMin;
			TickRatioHourF = (float)TickRatioHour;
			TickRatioDayF = (float)TickRatioDay;
			TickRatioWeekF = (float)TickRatioWeek;
			TickRatioSeasonF = (float)TickRatioSeason;
			TickRatioYearF = (float)TickRatioYear;
		}
	}
}
