using UnityEngine;

namespace GOC
{
    public class MousePosition3D : MonoBehaviour
    {
        [SerializeField] private Camera mainCamera;
        void Update()
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                transform.position = hit.point;
            }
        }
    }
}
