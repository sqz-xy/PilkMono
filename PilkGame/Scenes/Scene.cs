﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using PilkGame.Managers;

namespace PilkGame.Scenes;

public abstract class Scene : IScene
{
    protected readonly SceneManager mSceneManager;

    protected Scene(SceneManager pSceneManager)
    {
        mSceneManager = pSceneManager;
        pSceneManager.mUpdater = this.Update;
        pSceneManager.mRenderer = this.Render;
    }

    public abstract void Initialize();
    public abstract void Render(GameTime pGameTime, SpriteBatch pSpriteBatch);
    public abstract void Update(GameTime pGameTime);
    public abstract void Close();
}