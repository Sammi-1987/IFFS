﻿using CyberErp.Data.Model;
using CyberErp.Presentation.Iffs.Web.Classes;
using Ext.Direct.Mvc;
using Newtonsoft.Json;
using SwiftTederash.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberErp.Presentation.Iffs.Web.Controllers
{
    public class OperationStatusTemplateController : DirectController
    {
        #region Members

        private readonly DbContext _context;
        private readonly BaseModel<iffsOperationStatusTemplate> _operationStatusTemplate;

        #endregion

        #region Constructor

        public OperationStatusTemplateController()
        {
            _context = new ErpEntities(Constants.ConnectionString);
            _operationStatusTemplate = new BaseModel<iffsOperationStatusTemplate>(_context);
        }

        #endregion

        #region Actions

        public ActionResult Get(int id)
        {
            var objJobOrderTemplate = _operationStatusTemplate.Get(c=>c.Id == id);
            
            var jobOrderTemplate = new
            {
                objJobOrderTemplate.Id,
                objJobOrderTemplate.OperationTypeId,
                objJobOrderTemplate.Name,
                objJobOrderTemplate.Code,
                objJobOrderTemplate.Description,
                objJobOrderTemplate.DataTypeId,
                objJobOrderTemplate.PlannedDuration,
                objJobOrderTemplate.RoleId
            };
            return this.Json(new
            {
                success = true,
                data = jobOrderTemplate
            });
        }

        public ActionResult GetAll(int start, int limit, string sort, string dir, string param)
        {
            var hashtable = JsonConvert.DeserializeObject<Hashtable>(param);

            int operationTypeId;
            int.TryParse(hashtable["operationTypeId"].ToString(), out operationTypeId);

            var searchText = hashtable["searchText"].ToString();

            var records = _operationStatusTemplate.GetAll().Where(o=>o.OperationTypeId == operationTypeId);
            records = searchText != "" ? records.Where(p => p.iffsLupOperationType.Name.ToUpper().Contains(searchText.ToUpper())) : records;

            if (sort == "OperationType")
            {
                records = dir == "ASC" ? records.OrderBy(r => r.iffsLupOperationType.Name) : records.OrderByDescending(r => r.iffsLupOperationType.Name);
            }
            else if (sort == "DataType")
            {
                records = dir == "ASC" ? records.OrderBy(r => r.iffsLupDataType.Name) : records.OrderByDescending(r => r.iffsLupDataType.Name);
            }
            else if (sort == "Role")
            {
                records = dir == "ASC" ? records.OrderBy(r => r.coreRole.Name) : records.OrderByDescending(r => r.coreRole.Name);
            }
            else
            {
                records = dir == "ASC" ? records.OrderBy(r => r.GetType().GetProperty(sort).GetValue(r, null)) : records.OrderByDescending(r => r.GetType().GetProperty(sort).GetValue(r, null));
            }

            var count = records.Count();
            records = records.Skip(start).Take(limit);

            var operationStatusTemplates = records.Select(item => new
            {
                item.Id,
                item.OperationTypeId,
                OperationType = item.iffsLupOperationType.Name,
                item.Name,
                item.Code,
                item.Description,
                item.DataTypeId,
                DataType = item.iffsLupDataType.Name,
                item.PlannedDuration,
                item.RoleId,
                Role = item.coreRole.Name
            }).Cast<object>().ToList();
            
            var result = new { total = count, data = operationStatusTemplates };
            return this.Json(result);
        }

        [FormHandler]
        public ActionResult Save(iffsOperationStatusTemplate operationStatusTemplate)
        {
            if (operationStatusTemplate.Id.Equals(0))
            {
                _operationStatusTemplate.AddNew(operationStatusTemplate);
            }
            else
            {
                _operationStatusTemplate.Edit(operationStatusTemplate);
            }

            return this.Json(new { success = true, data = "Data has been saved successfully!" });
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _operationStatusTemplate.Delete(c=>c.Id == id);
                
                return this.Json(new { success = true, data = "record has been successfully deleted!" });
            }
            catch (Exception)
            {
                return this.Json(new { success = false, data = "Could not delete the selected record!" });
            }
        }

        #endregion  

        #region Methods
        
        #endregion
    }
}