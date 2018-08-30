using UnityEngine;

public class SwipeControl : MonoBehaviour
{
    [SerializeField] private Swipe swipeLogic;
    private Vector3 destination;

    private void Update()
    {
        if (swipeLogic.SwipeLeft)
        {
            destination += Vector3.left;
        }

        if (swipeLogic.SwipeRight)
        {
            destination += Vector3.right;
        }

        if (swipeLogic.SwipeUp)
        {
            destination += Vector3.forward;
        }

        if (swipeLogic.SwipeDown)
        {
            destination += Vector3.back;
        }

        gameObject.transform.position =
            Vector3.MoveTowards(gameObject.transform.position, destination, 2f * Time.deltaTime);

        if (swipeLogic.Tap)
        {
            Debug.Log("Tap!");
        }
    }
}