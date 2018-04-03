﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace WebWordPressLibrary
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WebWordPressLibraryRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
    [RepositoryFolder("5251cef1-231f-4e1a-b0bd-41e54b4b13f8")]
    public partial class WebWordPressLibraryRepository : RepoGenBaseFolder
    {
        static WebWordPressLibraryRepository instance = new WebWordPressLibraryRepository();
        WebWordPressLibraryRepositoryFolders.WordPress_DemoAppFolder _wordpress_demo;
        WebWordPressLibraryRepositoryFolders.IE_PopupAppFolder _ie_popup;

        /// <summary>
        /// Gets the singleton class instance representing the WebWordPressLibraryRepository element repository.
        /// </summary>
        [RepositoryFolder("5251cef1-231f-4e1a-b0bd-41e54b4b13f8")]
        public static WebWordPressLibraryRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WebWordPressLibraryRepository() 
            : base("WebWordPressLibraryRepository", "/", null, 0, false, "5251cef1-231f-4e1a-b0bd-41e54b4b13f8", ".\\RepositoryImages\\WebWordPressLibraryRepository5251cef1.rximgres")
        {
            _wordpress_demo = new WebWordPressLibraryRepositoryFolders.WordPress_DemoAppFolder(this);
            _ie_popup = new WebWordPressLibraryRepositoryFolders.IE_PopupAppFolder(this);
        }

#region Variables

        string _varPostTitle = "Ranorex is awesome!";

        /// <summary>
        /// Gets or sets the value of variable varPostTitle.
        /// </summary>
        [TestVariable("29335f94-7125-4a66-b789-5db5390570d1")]
        public string varPostTitle
        {
            get { return _varPostTitle; }
            set { _varPostTitle = value; }
        }

        string _varPostURL = "http://webtest.ranorex.org/";

        /// <summary>
        /// Gets or sets the value of variable varPostURL.
        /// </summary>
        [TestVariable("38650ea2-a352-43df-89fe-6205bdabe5c4")]
        public string varPostURL
        {
            get { return _varPostURL; }
            set { _varPostURL = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("5251cef1-231f-4e1a-b0bd-41e54b4b13f8")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The WordPress_Demo folder.
        /// </summary>
        [RepositoryFolder("1155ad1c-67f9-47e2-b216-3b27bda1db0b")]
        public virtual WebWordPressLibraryRepositoryFolders.WordPress_DemoAppFolder WordPress_Demo
        {
            get { return _wordpress_demo; }
        }

        /// <summary>
        /// The IE_Popup folder.
        /// </summary>
        [RepositoryFolder("ebf541e8-0e0c-46fd-9f2c-fa2381326c1c")]
        public virtual WebWordPressLibraryRepositoryFolders.IE_PopupAppFolder IE_Popup
        {
            get { return _ie_popup; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
    public partial class WebWordPressLibraryRepositoryFolders
    {
        /// <summary>
        /// The WordPress_DemoAppFolder folder.
        /// </summary>
        [RepositoryFolder("1155ad1c-67f9-47e2-b216-3b27bda1db0b")]
        public partial class WordPress_DemoAppFolder : RepoGenBaseFolder
        {
            WebWordPressLibraryRepositoryFolders.LoginformFolder _loginform;
            RepoItemInfo _postsInfo;
            RepoItemInfo _addnewInfo;
            RepoItemInfo _allpostsInfo;
            RepoItemInfo _titleInfo;
            RepoItemInfo _editpostInfo;
            RepoItemInfo _postcontentInfo;
            RepoItemInfo _logoutInfo;
            RepoItemInfo _movetotrashInfo;
            RepoItemInfo _samplepermalinkInfo;
            RepoItemInfo _publishInfo;
            RepoItemInfo _myaccount1Info;
            RepoItemInfo _pagetitleInfo;
            RepoItemInfo _dashboardInfo;
            RepoItemInfo _recentpostInfo;
            RepoItemInfo _contentInfo;

            /// <summary>
            /// Creates a new WordPress_Demo  folder.
            /// </summary>
            public WordPress_DemoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WordPress_Demo", "/dom[@domain='webtest.ranorex.org']", parentFolder, 30000, null, false, "1155ad1c-67f9-47e2-b216-3b27bda1db0b", "")
            {
                _loginform = new WebWordPressLibraryRepositoryFolders.LoginformFolder(this);
                _postsInfo = new RepoItemInfo(this, "Posts", ".//li[#'menu-posts']", 30000, null, "b7d60911-7c2c-4958-baf7-534def07cbb1");
                _addnewInfo = new RepoItemInfo(this, "AddNew", ".//li[#'menu-posts']//a[@innertext='Add New']", 30000, null, "e255ffb3-e703-4ab6-a36e-c2ed602282a5");
                _allpostsInfo = new RepoItemInfo(this, "AllPosts", ".//li[#'menu-posts']//a[@innertext='All Posts']", 30000, null, "44201c90-e37b-4ed1-a21a-8fd6e663c06d");
                _titleInfo = new RepoItemInfo(this, "Title", ".//input[#'title']", 30000, null, "f43fe2b4-c640-4dc4-b194-44d82e79d736");
                _editpostInfo = new RepoItemInfo(this, "EditPost", ".//li[#'wp-admin-bar-edit']/a[@innertext='Edit Post']", 30000, null, "058f30ed-a7a9-42fe-8fc9-1fc0359efabf");
                _postcontentInfo = new RepoItemInfo(this, "PostContent", ".//div[@id>'post-']/div[@class='entry']/p", 30000, null, "3f002dd9-dc74-4383-a479-13564ad81715");
                _logoutInfo = new RepoItemInfo(this, "LogOut", ".//li[#'wp-admin-bar-logout']/a[@innertext='Log Out']", 30000, null, "1b88e9a6-3588-4e2f-a970-9a0c951cd799");
                _movetotrashInfo = new RepoItemInfo(this, "MoveToTrash", ".//div[#'delete-action']/a[@innertext='Move to Trash']", 30000, null, "baf7acf6-9968-4f11-920f-c8a8ae26ceb1");
                _samplepermalinkInfo = new RepoItemInfo(this, "SamplePermalink", ".//span[#'sample-permalink']", 30000, null, "a75cd9f8-99bc-40c3-9ddc-8f2f3aaa705e");
                _publishInfo = new RepoItemInfo(this, "Publish", ".//input[@id='publish' and @class!~'disabled']", 30000, null, "87655afb-b7fd-4c8f-a620-fb5852b80b45");
                _myaccount1Info = new RepoItemInfo(this, "MyAccount1", ".//li[#'wp-admin-bar-my-account']/a[@innertext='Howdy, Ranorex Webtest new']", 30000, null, "941d4a5d-4fc3-4bce-b0b7-f75c361aec56");
                _pagetitleInfo = new RepoItemInfo(this, "Pagetitle", ".//h1[#'pagetitle']", 30000, null, "d33d1a10-1f16-498d-9ff5-54a4c542f24b");
                _dashboardInfo = new RepoItemInfo(this, "Dashboard", ".//li[#'menu-dashboard']", 30000, null, "20d79271-5608-4b0b-9f91-e52976c473af");
                _recentpostInfo = new RepoItemInfo(this, "RecentPost", ".//li[#'recent-posts-2']//a[@href=$varPostURL]", 30000, null, "bb18736e-7f5b-4b59-a50b-8ec22986e78b");
                _contentInfo = new RepoItemInfo(this, "Content", ".//textarea[@id='content']", 30000, null, "204ae0f9-7b3c-4a6d-b273-d9006e35a5c2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1155ad1c-67f9-47e2-b216-3b27bda1db0b")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1155ad1c-67f9-47e2-b216-3b27bda1db0b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Posts item.
            /// </summary>
            [RepositoryItem("b7d60911-7c2c-4958-baf7-534def07cbb1")]
            public virtual Ranorex.LiTag Posts
            {
                get
                {
                    return _postsInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The Posts item info.
            /// </summary>
            [RepositoryItemInfo("b7d60911-7c2c-4958-baf7-534def07cbb1")]
            public virtual RepoItemInfo PostsInfo
            {
                get
                {
                    return _postsInfo;
                }
            }

            /// <summary>
            /// The AddNew item.
            /// </summary>
            [RepositoryItem("e255ffb3-e703-4ab6-a36e-c2ed602282a5")]
            public virtual Ranorex.ATag AddNew
            {
                get
                {
                    return _addnewInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AddNew item info.
            /// </summary>
            [RepositoryItemInfo("e255ffb3-e703-4ab6-a36e-c2ed602282a5")]
            public virtual RepoItemInfo AddNewInfo
            {
                get
                {
                    return _addnewInfo;
                }
            }

            /// <summary>
            /// The AllPosts item.
            /// </summary>
            [RepositoryItem("44201c90-e37b-4ed1-a21a-8fd6e663c06d")]
            public virtual Ranorex.ATag AllPosts
            {
                get
                {
                    return _allpostsInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AllPosts item info.
            /// </summary>
            [RepositoryItemInfo("44201c90-e37b-4ed1-a21a-8fd6e663c06d")]
            public virtual RepoItemInfo AllPostsInfo
            {
                get
                {
                    return _allpostsInfo;
                }
            }

            /// <summary>
            /// The Title item.
            /// </summary>
            [RepositoryItem("f43fe2b4-c640-4dc4-b194-44d82e79d736")]
            public virtual Ranorex.InputTag Title
            {
                get
                {
                    return _titleInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Title item info.
            /// </summary>
            [RepositoryItemInfo("f43fe2b4-c640-4dc4-b194-44d82e79d736")]
            public virtual RepoItemInfo TitleInfo
            {
                get
                {
                    return _titleInfo;
                }
            }

            /// <summary>
            /// The EditPost item.
            /// </summary>
            [RepositoryItem("058f30ed-a7a9-42fe-8fc9-1fc0359efabf")]
            public virtual Ranorex.ATag EditPost
            {
                get
                {
                    return _editpostInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The EditPost item info.
            /// </summary>
            [RepositoryItemInfo("058f30ed-a7a9-42fe-8fc9-1fc0359efabf")]
            public virtual RepoItemInfo EditPostInfo
            {
                get
                {
                    return _editpostInfo;
                }
            }

            /// <summary>
            /// The PostContent item.
            /// </summary>
            [RepositoryItem("3f002dd9-dc74-4383-a479-13564ad81715")]
            public virtual Ranorex.PTag PostContent
            {
                get
                {
                    return _postcontentInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The PostContent item info.
            /// </summary>
            [RepositoryItemInfo("3f002dd9-dc74-4383-a479-13564ad81715")]
            public virtual RepoItemInfo PostContentInfo
            {
                get
                {
                    return _postcontentInfo;
                }
            }

            /// <summary>
            /// The LogOut item.
            /// </summary>
            [RepositoryItem("1b88e9a6-3588-4e2f-a970-9a0c951cd799")]
            public virtual Ranorex.ATag LogOut
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LogOut item info.
            /// </summary>
            [RepositoryItemInfo("1b88e9a6-3588-4e2f-a970-9a0c951cd799")]
            public virtual RepoItemInfo LogOutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }

            /// <summary>
            /// The MoveToTrash item.
            /// </summary>
            [RepositoryItem("baf7acf6-9968-4f11-920f-c8a8ae26ceb1")]
            public virtual Ranorex.ATag MoveToTrash
            {
                get
                {
                    return _movetotrashInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The MoveToTrash item info.
            /// </summary>
            [RepositoryItemInfo("baf7acf6-9968-4f11-920f-c8a8ae26ceb1")]
            public virtual RepoItemInfo MoveToTrashInfo
            {
                get
                {
                    return _movetotrashInfo;
                }
            }

            /// <summary>
            /// The SamplePermalink item.
            /// </summary>
            [RepositoryItem("a75cd9f8-99bc-40c3-9ddc-8f2f3aaa705e")]
            public virtual Ranorex.SpanTag SamplePermalink
            {
                get
                {
                    return _samplepermalinkInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SamplePermalink item info.
            /// </summary>
            [RepositoryItemInfo("a75cd9f8-99bc-40c3-9ddc-8f2f3aaa705e")]
            public virtual RepoItemInfo SamplePermalinkInfo
            {
                get
                {
                    return _samplepermalinkInfo;
                }
            }

            /// <summary>
            /// The Publish item.
            /// </summary>
            [RepositoryItem("87655afb-b7fd-4c8f-a620-fb5852b80b45")]
            public virtual Ranorex.InputTag Publish
            {
                get
                {
                    return _publishInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Publish item info.
            /// </summary>
            [RepositoryItemInfo("87655afb-b7fd-4c8f-a620-fb5852b80b45")]
            public virtual RepoItemInfo PublishInfo
            {
                get
                {
                    return _publishInfo;
                }
            }

            /// <summary>
            /// The MyAccount1 item.
            /// </summary>
            [RepositoryItem("941d4a5d-4fc3-4bce-b0b7-f75c361aec56")]
            public virtual Ranorex.ATag MyAccount1
            {
                get
                {
                    return _myaccount1Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The MyAccount1 item info.
            /// </summary>
            [RepositoryItemInfo("941d4a5d-4fc3-4bce-b0b7-f75c361aec56")]
            public virtual RepoItemInfo MyAccount1Info
            {
                get
                {
                    return _myaccount1Info;
                }
            }

            /// <summary>
            /// The Pagetitle item.
            /// </summary>
            [RepositoryItem("d33d1a10-1f16-498d-9ff5-54a4c542f24b")]
            public virtual Ranorex.H1Tag Pagetitle
            {
                get
                {
                    return _pagetitleInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The Pagetitle item info.
            /// </summary>
            [RepositoryItemInfo("d33d1a10-1f16-498d-9ff5-54a4c542f24b")]
            public virtual RepoItemInfo PagetitleInfo
            {
                get
                {
                    return _pagetitleInfo;
                }
            }

            /// <summary>
            /// The Dashboard item.
            /// </summary>
            [RepositoryItem("20d79271-5608-4b0b-9f91-e52976c473af")]
            public virtual Ranorex.LiTag Dashboard
            {
                get
                {
                    return _dashboardInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The Dashboard item info.
            /// </summary>
            [RepositoryItemInfo("20d79271-5608-4b0b-9f91-e52976c473af")]
            public virtual RepoItemInfo DashboardInfo
            {
                get
                {
                    return _dashboardInfo;
                }
            }

            /// <summary>
            /// The RecentPost item.
            /// </summary>
            [RepositoryItem("bb18736e-7f5b-4b59-a50b-8ec22986e78b")]
            public virtual Ranorex.ATag RecentPost
            {
                get
                {
                    return _recentpostInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The RecentPost item info.
            /// </summary>
            [RepositoryItemInfo("bb18736e-7f5b-4b59-a50b-8ec22986e78b")]
            public virtual RepoItemInfo RecentPostInfo
            {
                get
                {
                    return _recentpostInfo;
                }
            }

            /// <summary>
            /// The Content item.
            /// </summary>
            [RepositoryItem("204ae0f9-7b3c-4a6d-b273-d9006e35a5c2")]
            public virtual Ranorex.TextAreaTag Content
            {
                get
                {
                    return _contentInfo.CreateAdapter<Ranorex.TextAreaTag>(true);
                }
            }

            /// <summary>
            /// The Content item info.
            /// </summary>
            [RepositoryItemInfo("204ae0f9-7b3c-4a6d-b273-d9006e35a5c2")]
            public virtual RepoItemInfo ContentInfo
            {
                get
                {
                    return _contentInfo;
                }
            }

            /// <summary>
            /// The Loginform folder.
            /// </summary>
            [RepositoryFolder("3f312045-ef8c-48be-bc45-f4ee5cc2b3a2")]
            public virtual WebWordPressLibraryRepositoryFolders.LoginformFolder Loginform
            {
                get { return _loginform; }
            }
        }

        /// <summary>
        /// The LoginformFolder folder.
        /// </summary>
        [RepositoryFolder("3f312045-ef8c-48be-bc45-f4ee5cc2b3a2")]
        public partial class LoginformFolder : RepoGenBaseFolder
        {
            RepoItemInfo _userloginInfo;
            RepoItemInfo _userpassInfo;
            RepoItemInfo _wpsubmitInfo;

            /// <summary>
            /// Creates a new Loginform  folder.
            /// </summary>
            public LoginformFolder(RepoGenBaseFolder parentFolder) :
                    base("Loginform", ".//form[#'loginform']", parentFolder, 30000, null, false, "3f312045-ef8c-48be-bc45-f4ee5cc2b3a2", "")
            {
                _userloginInfo = new RepoItemInfo(this, "UserLogin", ".//input[@id='user_login']", 30000, null, "73564b76-2882-43c3-b20b-ae17d266067d");
                _userpassInfo = new RepoItemInfo(this, "UserPass", ".//input[@id='user_pass']", 30000, null, "9ba00e0e-2cec-4c4c-be2d-ee6ce280d0a5");
                _wpsubmitInfo = new RepoItemInfo(this, "WpSubmit", "?/?/input[@id='wp-submit']", 30000, null, "4f9f5619-5b52-4764-9765-e16693137316");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3f312045-ef8c-48be-bc45-f4ee5cc2b3a2")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3f312045-ef8c-48be-bc45-f4ee5cc2b3a2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The UserLogin item.
            /// </summary>
            [RepositoryItem("73564b76-2882-43c3-b20b-ae17d266067d")]
            public virtual Ranorex.InputTag UserLogin
            {
                get
                {
                    return _userloginInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserLogin item info.
            /// </summary>
            [RepositoryItemInfo("73564b76-2882-43c3-b20b-ae17d266067d")]
            public virtual RepoItemInfo UserLoginInfo
            {
                get
                {
                    return _userloginInfo;
                }
            }

            /// <summary>
            /// The UserPass item.
            /// </summary>
            [RepositoryItem("9ba00e0e-2cec-4c4c-be2d-ee6ce280d0a5")]
            public virtual Ranorex.InputTag UserPass
            {
                get
                {
                    return _userpassInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserPass item info.
            /// </summary>
            [RepositoryItemInfo("9ba00e0e-2cec-4c4c-be2d-ee6ce280d0a5")]
            public virtual RepoItemInfo UserPassInfo
            {
                get
                {
                    return _userpassInfo;
                }
            }

            /// <summary>
            /// The WpSubmit item.
            /// </summary>
            [RepositoryItem("4f9f5619-5b52-4764-9765-e16693137316")]
            public virtual Ranorex.InputTag WpSubmit
            {
                get
                {
                    return _wpsubmitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The WpSubmit item info.
            /// </summary>
            [RepositoryItemInfo("4f9f5619-5b52-4764-9765-e16693137316")]
            public virtual RepoItemInfo WpSubmitInfo
            {
                get
                {
                    return _wpsubmitInfo;
                }
            }
        }

        /// <summary>
        /// The IE_PopupAppFolder folder.
        /// </summary>
        [RepositoryFolder("ebf541e8-0e0c-46fd-9f2c-fa2381326c1c")]
        public partial class IE_PopupAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonnoInfo;

            /// <summary>
            /// Creates a new IE_Popup  folder.
            /// </summary>
            public IE_PopupAppFolder(RepoGenBaseFolder parentFolder) :
                    base("IE_Popup", "/form[@processname='iexplore' and @accessiblerole='Dialog']", parentFolder, 30000, null, false, "ebf541e8-0e0c-46fd-9f2c-fa2381326c1c", "")
            {
                _buttonnoInfo = new RepoItemInfo(this, "ButtonNo", "button[2]", 30000, null, "855eb7db-d3f0-4d3d-af8f-f158a445d79e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ebf541e8-0e0c-46fd-9f2c-fa2381326c1c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ebf541e8-0e0c-46fd-9f2c-fa2381326c1c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonNo item.
            /// </summary>
            [RepositoryItem("855eb7db-d3f0-4d3d-af8f-f158a445d79e")]
            public virtual Ranorex.Button ButtonNo
            {
                get
                {
                    return _buttonnoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonNo item info.
            /// </summary>
            [RepositoryItemInfo("855eb7db-d3f0-4d3d-af8f-f158a445d79e")]
            public virtual RepoItemInfo ButtonNoInfo
            {
                get
                {
                    return _buttonnoInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}