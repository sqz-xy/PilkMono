﻿namespace PilkGame.Scenes;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

/// <summary>
/// The types of scene, used for changing scene
/// </summary>
public enum SceneTypes
{
    SceneMainMenu,
}

/// <summary>
/// Interface for implementing a new scene
/// </summary>
public interface IScene
{
    /// <summary>
    /// Initialization logic for the scene goes in here
    /// </summary>
    void Initialize();
    
    /// <summary>
    /// Render logic for the scene goes in here
    /// </summary>
    /// <param name="pFrameEventArgs"></param>
    void Render(GameTime pGameTime, SpriteBatch pSpriteBatch);
    
    /// <summary>
    /// Update logic for the scene goes in here
    /// </summary>
    /// <param name="pFrameEventArgs"></param>
    void Update(GameTime pGameTime);
    
    /// <summary>
    /// Cleanup logic for the scene goes here
    /// </summary>
    void Close();
}