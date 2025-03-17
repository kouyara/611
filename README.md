# 611
programing3のVRゲーム開発

このリポジトリでは、Unityを使用したVRゲーム開発プロジェクト「611」のソースコードを管理しています。

---

## 目次
1. [概要](#概要)  
2. [準備](#準備)  
   - [リポジトリのクローン](#リポジトリのクローン)
   - [Unity Hub とエディタのインストール](#unity-hub-とエディタのインストール)
   - [Unity プロジェクトの読み込み](#unity-プロジェクトの読み込み)
3. [実行のやり方](#実行のやり方)  
4. [その他](#その他)
5. [ライセンス](#ライセンス)

---

## 概要
- このプロジェクトは、**VRゲーム開発**に特化したUnityプロジェクトです。
- リポジトリのサイズは約 `8.96GB` あります。クローン時には十分なストレージを確保してください。

---

## 準備

### リポジトリのクローン
```bash
git clone https://github.com/kouyara/611.git
```
Note: 容量は約 8.96GB あります。

## Unity Hub とエディタのインストール
1. Unity Hub をインストールする
2. Unity バージョン 2021.3.25f1 を Unity Hub から導入する
3. 以下のモジュールを追加インストールする（容量は約 18.74GB）
* Android Build Support
* OpenJDK
* Android SDK & NDK Tools
* Mac Build Support (IL2CPP)
* Mac Dedicated Server Build Support
* WebGL Build Support

## Unity プロジェクトの読み込み
1. Unity Hub を起動し、「Projects」または「プロジェクト」タブから「Add」ボタンを押す
2. ローカルにクローン済みの「611」フォルダを選択してプロジェクトを登録
3. Unity Hub 上のプロジェクト一覧に「611」が追加されるので、クリックして開く

## 実行のやり方
1. Unity エディタを起動したら、画面左上のメニューから「File」 -> 「Build Settings」を選択
2. 「Scenes In Build」の一覧にあるシーンにすべてチェックを入れる
3. 「Texture Compression」は ASTC に設定
4. Oculus QuestをPCに接続する
5. 「Run Device」は「Oculus Quest」を選択
6. 「Change Target」を押す（必要に応じてプラットフォームを変更）
7. 「Build And Run」をクリックし、ビルドおよび実行する

## その他
* プロジェクト内にリソースやアセットが多いため、ビルドには時間がかかる場合があります。
* 実機 (Oculus Quest) の接続がうまくいかない場合は、公式ドキュメントも参考にしてください。
* 何か不明点や不具合があれば、Issue や Pull Request でお知らせください。

## ライセンス
本プロジェクトのライセンスは GNU General Public License (GPL 2.0) を想定しています。
