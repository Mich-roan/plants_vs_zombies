using UnityEngine;

public class LaneManager : MonoBehaviour
{
    [SerializeField]
    private Lane[] lanes;
    public Transform GetFrameInLane()
    {
        int laneIndex = Random.Range(0, lanes.Length);
        Lane SelectedLane = lanes[laneIndex];
        int frameIndex = Random.Range(0, SelectedLane.Frames.Count);
        return SelectedLane.Frames[frameIndex];
    }
}
