using Unity.VisualScripting;
using UnityEngine;

public class RotacionPivot : MonoBehaviour
{
    [SerializeField] Transform Pivot;
    [SerializeField] Transform Mano;
    void Update()
    {
        Vector3 PosicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 LookAtDirection = PosicionMouse - Pivot.position;
        float angulo = Mathf.Atan2(LookAtDirection.y, LookAtDirection.x) * Mathf.Rad2Deg;
        Pivot.rotation = Quaternion.Euler(0, 0, angulo);
    }
}
