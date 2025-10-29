using UnityEngine;

public class rotateController : MonoBehaviour
{
   public GameObject PlanetObject;
   public Vector3 rotationVector;

   private void Update()
   {
       PlanetObject.transform.Rotate(rotationVector * Time.deltaTime);
   }
}
