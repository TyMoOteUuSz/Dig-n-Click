﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BasicEconomyValues
{
    // Ascending cost
    public const int BaseAscendCost = 5;
    public const int AscendBias = -1;
    public const float AscendExponentialMultiplier = 1.14f;

    // Rock values
    public const int BaseHealth = 4;
    public const int HealthBias = 5;
    public const float HealthExponentialMultiplier = 1.14f;
    public const float RockFallingTime = 0.3f;

    // Upgrade values
    public const int ToBeAdded = 0;

    // Earnings
    public const float BaseEarnings = 1.5f;

    public static double Exponent(int baseValue, int bias, float exponentialMultiplier, int level)
    {
        return Mathf.Round(baseValue * Mathf.Pow(exponentialMultiplier, level) + bias);
    }

    public static double MoneyReward(int level)
    {
        return Mathf.Round(BaseEarnings * level);
    }
}
