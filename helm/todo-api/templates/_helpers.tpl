{{/*
Create a default fully qualified app name.
*/}}
{{- define "todo-api.fullname" -}}
{{- .Chart.Name -}}
{{- end }}

{{/*
Selector labels.
*/}}
{{- define "todo-api.selectorLabels" -}}
app: {{ .Chart.Name }}
{{- end }}
