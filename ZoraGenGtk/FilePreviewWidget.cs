﻿/*
 * Copyright © 2013-2015, Andrew Nagle.
 * All rights reserved.
 * 
 * This file is part of ZoraGen GTK.
 *
 * ZoraGen GTK is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ZoraGen GTK is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with ZoraGen GTK.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using Zyrenth.Zora;

namespace Zyrenth.ZoraGen.GtkUI
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class FilePreviewWidget : Gtk.Bin
	{
		private GameInfo _info;

		public GameInfo GameInfo
		{
			get { return _info; }
			set
			{
				_info = value;
				SetControls();
			}
		}

		public FilePreviewWidget()
		{
			this.Build();
		}

		public FilePreviewWidget(GameInfo info)
			: this()
		{
			GameInfo = info;
		}

		private void SetControls()
		{
			lblHero.Text = _info.Hero;
			lblID.Text = _info.GameID.ToString();
			lblGame.Text = _info.Game.ToString();
			lblChild.Text = _info.Child;
			lblAnimal.Text = _info.Animal.ToString();
			lblBehavior.Text = _info.Behavior.ToString();
			imgTriforce.Visible = _info.IsHeroQuest;
		}
	}
}

