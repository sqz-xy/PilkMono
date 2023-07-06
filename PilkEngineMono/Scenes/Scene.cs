﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using PilkEngineMono.Managers;

namespace PilkEngineMono.Scenes;

public abstract class Scene : IScene
{
    protected readonly SceneManager mSceneManager;

    protected Scene(SceneManager pSceneManager)
    {
        mSceneManager = pSceneManager;
        pSceneManager.mUpdater = Update;
        pSceneManager.mRenderer = Render;
    }

    public abstract void Initialize();
    public abstract void Render(GameTime pGameTime, SpriteBatch pSpriteBatch);
    public abstract void Update(GameTime pGameTime);
    public abstract void Close();
    public void ChangeScene(SceneTypes pSceneType)
    {
        mSceneManager.ChangeScene(pSceneType);
    }
}