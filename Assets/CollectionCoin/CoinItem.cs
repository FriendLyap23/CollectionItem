using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CoinItem : MonoBehaviour
{
    private Coin _instance = Coin.instance;
    [SerializeField] private CircleCollider2D _circleCollider2D;
    [SerializeField] private int _coinCost;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.GetComponent<MainCharacterMovement>() != null)
        {
            if (_instance.countCoin >= Coin.MAX_COINS)
            {
                _circleCollider2D.isTrigger = false;
                return;
            }
            else
                _circleCollider2D.isTrigger = true;

            _instance.AddCoin(_coinCost);
            Destroy(gameObject);
        }
    }
}
