
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Interacatable : MonoBehaviour
{
    public class Interactable : MonoBehaviour
    {
        public float radius = 3f;

        bool isFocus = false;
        Transform player;

        private void Update()
        {
            if (isFocus)
            {
                float distance = Vector3.Distance(player.position, transform.position);
                if (distance <= radius)
                {
                    Debug.Log("Interakcja");
                }
            }
        }

        public void OnFocused (Transform playerTransform)
        {
            isFocus = true;
            player = playerTransform;
        }
        public void OnDeFocused ()
        {
            isFocus = false;
            player = null;

        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }

}
