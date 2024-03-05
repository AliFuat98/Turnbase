using UnityEngine;

public class UnitMovement : MonoBehaviour {
  Vector3 targetPosition = new Vector3(5,0,5);

  void Move(Vector3 targetPosition) {
    this.targetPosition = targetPosition;
  }

  void Update() {
    float distance = Vector3.Distance(transform.position, targetPosition);
    float stoppingDistance = 0.1f;
    if (distance > stoppingDistance) {
      Vector3 moveDirection = (targetPosition - transform.position).normalized;
      float moveSpeed = 4f;
      transform.position += moveSpeed * Time.deltaTime * moveDirection;
    }
  }
}