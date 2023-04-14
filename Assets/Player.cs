using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 10;
    public CharacterController _characterController;

    private void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis ("Vertical");

        if (h != 0 || v != 0)
        {
            var vector = new Vector3(h, 0, v);

            vector = this.transform.TransformDirection(vector);

            _characterController.SimpleMove(vector * _speed);
        }
    }
}
