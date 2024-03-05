using UnityEngine;

public class MouseWorld : MonoBehaviour {
  private static MouseWorld Instance;

  void Awake() {
    Instance = this;
  }

  [SerializeField] LayerMask mousePlaneLayerMask;

  public static Vector3 GetPosition() {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    Physics.Raycast(ray, out RaycastHit hitInfo, float.MaxValue, Instance.mousePlaneLayerMask);
    return hitInfo.point;
  }
}