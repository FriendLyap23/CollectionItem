using UnityEngine;

public abstract class CollectionItem : MonoBehaviour
{
    public void CollectionAnItem(Collider2D collider2D, GameObject gameObject)
    {
        if (collider2D.gameObject.layer == LayerMask.NameToLayer("Player"))
            Destroy(gameObject);
    }   
}
