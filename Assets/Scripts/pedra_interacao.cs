using UnityEngine;

public class PedraInteracao : MonoBehaviour
{
	[Header("Referências")]
	public AudioSource audioSource;

	[Header("Animação")]
	public float distanciaSlide = 2f;
	public float velocidade = 2f;

	private bool ativada = false;
	private Vector3 posicaoOriginal;
	private Vector3 posicaoAlvo;

	void Start()
	{
		posicaoOriginal = transform.localPosition;
		posicaoAlvo = posicaoOriginal + new Vector3(distanciaSlide, 0, 0);
	}

	void Update()
	{
		if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) ||
			OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
		{
			Transform rightHand = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch) != Vector3.zero
				? GameObject.Find("RightHandAnchor")?.transform
				: null;

			Transform origin = rightHand != null ? rightHand : Camera.main.transform;
			Ray ray = new Ray(origin.position, origin.forward);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform == this.transform || hit.transform.IsChildOf(this.transform))
				{
					AlternarEstado();
				}
			}
		}

		Vector3 destino = ativada ? posicaoAlvo : posicaoOriginal;
		transform.localPosition = Vector3.Lerp(transform.localPosition, destino, Time.deltaTime * velocidade);
	}

	void AlternarEstado()
	{
		ativada = !ativada;

		if (audioSource != null)
			audioSource.Play();
	}
}