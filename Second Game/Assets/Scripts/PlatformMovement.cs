using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
	public Vector3 deltaPosition;
	private Vector3 originalPosition;

	void Start()
	{
		originalPosition = transform.position;
	}

	void Update()
	{
		if (!FindObjectOfType<GameManager>().levelWon)
		{
			float velocity = 40f / deltaPosition.sqrMagnitude;
			float deltaVelocity = (Mathf.Sin(Time.timeSinceLevelLoad * velocity) + 1f) / 2f;

			Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
			rigidbody.position = Vector3.Lerp(originalPosition, originalPosition + deltaPosition, deltaVelocity);
		}
	}

	#if UNITY_EDITOR
	void OnDrawGizmos()
	{
		Gizmos.color = Color.gray;

		if (UnityEditor.Selection.activeTransform == transform)
		{
			Gizmos.color = Color.yellow;
		}

		Vector3 tweakedPosition = transform.position + deltaPosition;
		Vector3 tweakedSize = transform.rotation * transform.localScale * 2f;
		Gizmos.DrawWireCube(tweakedPosition, tweakedSize);
	}
	#endif
}