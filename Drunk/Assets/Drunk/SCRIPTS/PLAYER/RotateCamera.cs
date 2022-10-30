using UnityEngine;
using UnityEngine.Events;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float sensitivity = 2f;
    [SerializeField] private float smoothing = 1.5f;

    Transform gameObjectToRotateWith;

    private Vector2 velocity;
    private Vector2 frameVelocity;

    public UnityEvent onStart;


    void Start()
    {
        onStart?.Invoke();
    }

    void Update()
    {
        RotateCameraWithMouse();
    }

    public void StartSettings()
    {
        if (TryGetComponent(out Transform t))
        {
            gameObjectToRotateWith = GetComponentInParent<PlayerMovement>().transform;
            Debug.Log(gameObjectToRotateWith.name);
        }
        else
        {
            gameObjectToRotateWith = this.transform;
        }
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void RotateCameraWithMouse()
    {
        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector2 rawFrameVelocity = Vector2.Scale(mouseInput, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        gameObjectToRotateWith.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);

    }

}
