﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRider.uEpisodes.Core.Discovery
{
    public class EpisodeFileInfo
    {
        public EpisodeFileInfo()
        {
        }

        public VideoFileInfo    VideoFile { get; set; }

        public string ShowName { get; set; }


        public IEnumerable<VideoId> GetVideoIdCandidates()
        {
            foreach (var videoId in this.VideoFile.GetVideoIdCandidates())
            {



                yield return videoId;
            }
            
        }
    }
}
