using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartRecord.Services.Call
{
    public interface ICallRecorder
    {
        Task<bool> StartRecording();
        Task<bool> StopRecording();
        Task<bool> PauseRecording();
        Task<bool> ResumeRecording();
    }
}
