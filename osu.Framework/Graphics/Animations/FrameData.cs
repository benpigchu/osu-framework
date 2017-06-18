﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics.Containers;

namespace osu.Framework.Graphics.Animations
{
    /// <summary>
    /// Represents all data necessary to describe a single frame of an <see cref="Animation{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of animation the frame data is for.</typeparam>
    public struct FrameData<T>
    {
        /// <summary>
        /// The contents to display for the frame.
        /// </summary>
        public T Content { get; set; }

        /// <summary>
        /// The duration to display the frame for.
        /// </summary>
        public double Duration { get; set; }
    }
}
