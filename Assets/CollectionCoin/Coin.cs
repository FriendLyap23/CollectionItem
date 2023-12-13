using System;
public class Coin
{
    public const int MAX_COINS = 3;
    public int countCoin { get; private set; }

    public static Coin instance = new Coin();
    public static event Action<int> OnUpdatingCoinAccount;

    private void Awake()
    {
        instance = this;
    }

    public void AddCoin(int addedCoin) 
    {
        if (countCoin + addedCoin > MAX_COINS)
            countCoin = MAX_COINS;
        else
            countCoin += addedCoin;

        OnUpdatingCoinAccount?.Invoke(countCoin);
    }

    public void SpendCoin(int spentCoin) 
    {
        if (countCoin <= 0)
            countCoin = 0;
        else
            countCoin -= spentCoin;

        OnUpdatingCoinAccount?.Invoke(countCoin);
    }
}