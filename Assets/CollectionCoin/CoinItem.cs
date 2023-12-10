using UnityEngine;

public class CoinItem : CollectionItem
{
    private Coin _instance = Coin.instance;
    [SerializeField] private CoinEnum _coinEmum;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer == LayerMask.NameToLayer("Player"))
            _instance.AddCoin((int)_coinEmum);

        CollectionAnItem(collider2D, gameObject);
    }
}
