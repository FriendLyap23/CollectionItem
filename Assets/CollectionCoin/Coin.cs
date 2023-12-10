using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Coin instance = new Coin();

    public int countCoin { get; private set; }
    private const int _maxCoins = 99;

    public delegate void OnUpdatingCoinAccount(int countCoin);
    public static event OnUpdatingCoinAccount OnUpdatingCoinAccountEvent;

    public void Awake()
    {
        instance = this;
    }

    public void AddCoin(int addedCoin) 
    {
        if (countCoin + addedCoin > _maxCoins)
            throw new InvalidOperationException();

        countCoin += addedCoin;
        OnUpdatingCoinAccountEvent?.Invoke(countCoin);
    }
}
