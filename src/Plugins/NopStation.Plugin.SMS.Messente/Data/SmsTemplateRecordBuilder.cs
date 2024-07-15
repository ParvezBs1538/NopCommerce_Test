﻿using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using NopStation.Plugin.SMS.Messente.Domains;

namespace NopStation.Plugin.SMS.Messente.Data
{
    public class SmsTemplateRecordBuilder : NopEntityBuilder<SmsTemplate>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(SmsTemplate.Name))
                .AsString(int.MaxValue)
                .WithColumn(nameof(SmsTemplate.Body))
                .AsString(int.MaxValue)
                .NotNullable()
                .WithColumn(nameof(SmsTemplate.Active))
                .AsBoolean()
                .WithColumn(nameof(SmsTemplate.LimitedToStores))
                .AsBoolean();
        }
    }
}