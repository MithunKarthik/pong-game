using UnityEngine;
using UnityEngine.EventSystems;

public class Scoringzone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
 private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
           BaseEventData eventdata = new BaseEventData(EventSystem.current);
           this.scoreTrigger.Invoke(eventdata);
        }
       
    }
}
