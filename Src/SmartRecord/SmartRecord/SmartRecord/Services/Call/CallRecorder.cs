using Android.Media;
using Android.Telephony;
using System;
using System.Threading.Tasks;

namespace SmartRecord.Services.Call
{
    public class CallRecorder : ICallRecorder
    {
        public MediaRecorder recorder = new MediaRecorder();
        TelephonyManager t;

        public Task<bool> PauseRecording()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResumeRecording()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StartRecording()
        {
            
            recorder.Reset();
            recorder.SetAudioSource(AudioSource.VoiceCall);
            recorder.SetOutputFormat(OutputFormat.ThreeGpp);
            recorder.SetAudioEncoder(AudioEncoder.Aac);
            recorder.SetOutputFile("/sdcard/Download/123.3gpp");
            recorder.Prepare();
            recorder.Start();
           
            return true;
            
        }

        public async Task<bool> StopRecording()
        {
            recorder.Stop();
            recorder.Release();
            return true;
        }
    }
}
