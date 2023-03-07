using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MusicApp.Entities;

// Task - Create Music Application using database with entities
namespace MusicApp
{
    public partial class MusicApplication : Form
    {
        // data from entitites and data folders
        MusicAppDbContext db = new MusicAppDbContext();
        List<PlayList> playlists = new List<PlayList>();
        List<Track> tracks = new List<Track>();

        public MusicApplication()
        {
            InitializeComponent();
            UpdatePlaylistList();
        }
        private void UpdatePlaylistList()
        {
            playlistBox.DataSource = null;
            playlistBox.DataSource = playlists;
        }

        // add playlist
        private void AddPlBtnClick(object sender, EventArgs e)
        {
            CreatePlayList form = new CreatePlayList();

            playlists.Add(form.PlayList);
            UpdatePlaylistList();
        }

        // populate playlist
        private void PlaylistBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var playlist = playlistBox.SelectedItem as PlayList;
            if (playlist == null) { return; }

            playlistBox.DataSource = null;
            tracks.Clear();

            foreach (var track in playlist.Tracks)
            {
                tracks.Add(track);
            }

            playlistBox.DataSource = tracks;
        }
    }
}
