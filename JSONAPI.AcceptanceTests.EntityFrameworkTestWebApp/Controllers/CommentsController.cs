﻿using JSONAPI.EntityFramework.Tests.TestWebApp.Models;
using JSONAPI.Http;

namespace JSONAPI.EntityFramework.Tests.TestWebApp.Controllers
{
    public class CommentsController : JsonApiController<Comment>
    {
        public CommentsController(IDocumentMaterializer<Comment> documentMaterializer) : base(documentMaterializer)
        {
        }
    }
}