using UnityEngine;

public class MoveTowardsPlayerAi : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        var directionToPlayer = playerTransform.position - transform.position;

        directionToPlayer.Normalize();

        var horizontalDirection = directionToPlayer.x;
        //var verticalDirection = directionToPlayer.y;
        commandContainer.walkCommand = horizontalDirection;
    }
}
