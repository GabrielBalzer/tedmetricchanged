using UnityEditor;
using UnityEngine;

public class SnapToGround : MonoBehaviour
{
    // Start is called before the first frame update

    [MenuItem("Custom/Snap To Ground %g")]
    public static void Ground()
    {
        foreach (var transform in Selection.transforms)
        {
#pragma warning disable CS0168 // The variable 'hitInfo' is declared but never used
            RaycastHit2D hitInfo;
#pragma warning restore CS0168 // The variable 'hitInfo' is declared but never used
            var hits = Physics2D.RaycastAll(transform.position + Vector3.up, Vector3.down, 10f);
            foreach (var hit in hits)
            {
                if (hit.collider.gameObject == transform.gameObject)
                {
                    continue;
                }


                transform.position = hit.point;
                break;
            }
        }
    }
}