using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 1;
    public CharacterController _characterController;

    private void Start()
    {
        _characterController ??= this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        print("xxx");

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis ("Vertical");

        if (h != 0 || v != 0)
        {
            var vector = new Vector3(h, 0, v);

            vector = this.transform.TransformDirection(vector);

            _characterController.Move(vector * _speed);
        }
    }
}
